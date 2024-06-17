using System.IO;
using System.Windows;
using System.Xml.Serialization;
using WorkTimeLogger.Models;

namespace WorkTimeLogger;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        selectedDate = DateTime.UtcNow.Date;
        if (!File.Exists("Data.xml"))
            SerializeToXml<List<MeanDay>>(data, "Data.xml");
        else
            data = DeserializeFromXml<List<MeanDay>>("Data.xml");
    }

    DateTime selectedDate = new DateTime();

    List<MeanDay> data = new List<MeanDay>();

    public static void SerializeToXml<T>(T data, string filePath)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(T));
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            serializer.Serialize(writer, data);
        }
    }

    public static T DeserializeFromXml<T>(string filePath)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(T));
        using (StreamReader reader = new StreamReader(filePath))
        {
            return (T)serializer.Deserialize(reader);
        }
    }

}