using System.Xml.Serialization;

namespace Collections;

public class Program
{
    public static void Main()
    {

        //Collector.VolumeToXML();
        //Collector.BusesAndTrucksToXML();
        //Collector.TransmissionTypesToXML();

        XmlSerializer writer = new XmlSerializer(typeof(string));

        var path = Environment.CurrentDirectory + "VolumeToXML.xml";
        FileStream file = File.Create(path);
        writer.Serialize(file, Collector.VolumeToXML());
        file.Close();

        var path1 = Environment.CurrentDirectory + "BusesAndTrucksToXML.xml";
        FileStream file1 = File.Create(path1);
        writer.Serialize(file1, Collector.BusesAndTrucksToXML());
        file1.Close();

        var path2 = Environment.CurrentDirectory + "TransmissionTypesToXML.xml";
        FileStream file2 = File.Create(path2);
        writer.Serialize(file2, Collector.TransmissionTypesToXML());
        file2.Close();
    }
}