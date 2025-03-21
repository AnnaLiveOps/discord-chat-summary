using System;
using DiscordChatExporter.Cli;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        var token = Environment.GetEnvironmentVariable("DISCORD_TOKEN");
        var channelId = Environment.GetEnvironmentVariable("CHANNEL_ID");
        
        // Llama a DiscordChatExporter para exportar el chat
        var exporter = new DiscordChatExporterCli();
        var result = exporter.ExportMessages(token, channelId, "PlainText", "output.txt");
        
        Console.WriteLine("Export complete. File saved as output.txt.");
    }
}
