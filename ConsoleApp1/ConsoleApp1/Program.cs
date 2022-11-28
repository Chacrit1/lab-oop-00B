using System.Reflection;
using System.Linq;
class Student
{
    public string name;
    public int weight;

    public Student(string modelName,int modelWeight)
    {
        name = modelName;
        weight = modelWeight;

    }
    static void Main(string[] args)
    {
        Student student1 = new Student("Big",55);
        Student student2 = new Student("Palm", 60);
        Student student3 = new Student("Ta", 57);
        Student student4 = new Student("Ter", 59);
        Student student5 = new Student("Kang", 55);
        int[] weightList = { student1.weight , student2.weight , student3.weight , student4.weight , student5.weight };
        int max = weightList.Max();
        int min = weightList.Min();
        Console.WriteLine("แสดงค่าเฉลี่ยน้ำหนักของนักศึกษาทั้งหมด " + (student1.weight + student2.weight + student3.weight + student4.weight + student5.weight) / 5);
        Console.WriteLine("แสดงชื่อและน้ำหนักของคนที่มีน้ำหนักมากที่สุด "+max);
        Console.WriteLine("แสดงชื่อและน้ำหนักของคนที่มีน้ำหนักน้อยที่สุด "+min);
        Console.WriteLine("นาย ชาคริต พูลพิพิธ 653450507-9");

    }
}
