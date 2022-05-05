namespace MyClass
{
    public class Myclass
    {
        public int Rsch(double s, double K, double S, double R1, double R2, double R3)
        {
            if (s >=0 || K >= 0 || S >= 0 || R1 >= 0 || R2 >= 0 || R3 >= 0)
            {
                double R0 = Math.Sqrt(s / Math.PI);

                double R = Math.Sqrt(S / Math.PI);

                double L = Math.Pow(K * (R0 / R), 2);

                double[] arr = new double[3] { R1, R2, R3 };
                Array.Sort(arr);

                double C = Math.Pow(2 * arr[0], 2.5) + Math.Pow(2 * arr[1], 1.5) + Math.Pow(2 * arr[2], 0.5);

                int n = Convert.ToInt32(L / C);



                return n;
            }
            return -1;
        }
    }
}

/// s - пложщадь района обслуживания
/// S - покрытия базовой станции
/// R0 - радиус зоны обслуживания
/// R - радиус покрытия базовой станции
/// K - коофициент звстройки
/// L - среднее арифмитическое по всем базовым станциям
/// C - кол-во базовых станций в одном кластере
/// n - кол-во базовых станций
///