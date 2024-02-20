using MedidasConvercion;

Console.Write("Enter the number of meters: ");
double metros = Convert.ToDouble(Console.ReadLine());

double centimetros = Conversiones.MetrosACentimetros(metros);
double pulgadas = Conversiones.MetrosAPulgadas(metros);
double pies = Conversiones.MetrosAPies(metros);

Console.WriteLine(metros + " meters are equivalent to:");
Console.WriteLine( centimetros + " cm");
Console.WriteLine(pulgadas + " pulg");
Console.WriteLine(pies +" ft");
