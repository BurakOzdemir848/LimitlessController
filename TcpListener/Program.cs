using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

class Program
{
    static void Main()
    {
        var listener = new TcpListener(IPAddress.Loopback, 9000);
        listener.Start();
        Console.WriteLine("Universal Test server started on port 9000...");

        while (true)
        {
            var client = listener.AcceptTcpClient();
            Console.WriteLine("Client connected!");
            var stream = client.GetStream();
            byte[] buffer = new byte[1024];

            try
            {
                while (true)
                {
                    int read = stream.Read(buffer, 0, buffer.Length);
                    if (read == 0) break; // client kapattı

                    // Raw bytes
                    byte[] actualData = new byte[read];
                    Buffer.BlockCopy(buffer, 0, actualData, 0, read);

                    // ASCII mi kontrol et
                    bool ascii = true;
                    foreach (byte b in actualData)
                    {
                        if (b < 0x20 || b > 0x7E) // printable range
                        {
                            ascii = false;
                            break;
                        }
                    }

                    string incoming;
                    if (ascii)
                    {
                        incoming = Encoding.ASCII.GetString(actualData).Trim();
                        Console.WriteLine($"Received ASCII: {incoming}");
                    }
                    else
                    {
                        incoming = BitConverter.ToString(actualData).Replace("-", "");
                        Console.WriteLine($"Received RAW HEX: {incoming}");
                    }

                    byte[] resp;

                    switch (incoming.ToLower())
                    {
                        case "int16":
                            short int16Val = 333;
                            resp = BitConverter.GetBytes(int16Val);
                            break;

                        case "int32":
                            int int32Val = 22334;
                            resp = BitConverter.GetBytes(int32Val);
                            break;
                        case "int32-big":
                            int int32ValBig = 22334;
                            resp = new byte[4];
                            System.Buffers.Binary.BinaryPrimitives.WriteInt32BigEndian(resp, int32ValBig);
                            break;
                        case "float":
                            float floatVal = 123.45f;
                            resp = BitConverter.GetBytes(floatVal);
                            break;

                        case "double":
                            double doubleVal = 12345.6789;
                            resp = BitConverter.GetBytes(doubleVal);
                            break;

                        case "ascii":
                            resp = Encoding.ASCII.GetBytes("HELLO");
                            break;

                        case "hex":
                            resp = new byte[] { 0x12, 0x34, 0xAB, 0xCD };
                            break;

                        case "json":
                            string json = "{\"value\":123,\"status\":\"ok\"}";
                            resp = Encoding.UTF8.GetBytes(json);
                            break;

                        default:
                            // Eğer bilinmeyen ASCII komut ise
                            if (ascii)
                            {
                                resp = Encoding.ASCII.GetBytes("UNKNOWN CMD");
                            }
                            else
                            {
                                // Eğer raw hex geldiyse, örnek: echo mode
                                resp = actualData; // gelen byte'ı geri gönder
                            }
                            break;
                    }

                    stream.Write(resp, 0, resp.Length);
                    Console.WriteLine($"Sent {resp.Length} bytes\n");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Connection error: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Client disconnected.");
                client.Close();
            }
        }
    }
}
