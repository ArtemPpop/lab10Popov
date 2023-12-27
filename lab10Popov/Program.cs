ComplexResist cs = new ComplexResist(12,23,3);
cs.Print();

public class ComplexNumber
{
    private double real { get; set; }
    private double imaginary { get; set; }

    public ComplexNumber(double real, double imaginary)
    {
        this.real = real;
        this.imaginary = imaginary;
    }


}
public class ComplexResist : ComplexNumber
{
    public double resistance { get; set; }
    public double inductance { get; set; }
    public double angularFrequency { get; set; }

    public ComplexResist(double resistance, double inductance, double angularFrequency) : base(resistance, inductance)
    {
        this.resistance = resistance;
        this.inductance = inductance;
        this.angularFrequency = angularFrequency;
    }

    public double Magnitude()
    {
        double impedance = Math.Sqrt(Math.Pow(resistance, 2) + Math.Pow(angularFrequency * inductance - 1 / (angularFrequency * inductance), 2));
        return 1 / impedance;
    }

    public double Argument()
    {
   
        double arg = Math.Atan2(angularFrequency * inductance - 1 / (angularFrequency * inductance), resistance);
        return arg;
    }
    public void Print()
    {
        Console.WriteLine($"Сопротивление: {resistance}, Индуктивность: {inductance}, Частота: {angularFrequency}");
        double magnitude = Magnitude();
        double argument = Argument();
        Console.WriteLine($"Модуль проводимости: {magnitude:F2}, Аргумент проводимости: {argument:F2}");
    }
}



