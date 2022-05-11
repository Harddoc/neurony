using System;


namespace majma2
{
    class Warstwa
    {
        public int nr_warstwy;
        public int liczba_neuronow;
        public int funk_aktywacji;
        public double y = 0;
        public Warstwa(int nr_warstwy, int liczba_neuronow, int funk_aktywacji,double y) 
        {
            this.nr_warstwy = nr_warstwy;
            this.liczba_neuronow = liczba_neuronow;
            this.funk_aktywacji = funk_aktywacji;
            this.y = y;
        }
       
        public double unipol(double suma)
        {

            if (suma < 0)
            {
                y = 0;
            }
            else
            {
                y = 1;
            }
            return y;
        }
        protected double bipol(double suma)
        {
            if (suma < 0)
            {
                y = -1;
            }
            else
            {
                y = 1;
            }
            return y;
        }
        protected double C_unipol(double suma)
        {
            y = 1 / (1 + Math.Exp(-1 * suma));
            return y;

        }
        protected double C_bipol(double suma)
        {
            y = (1 - Math.Exp(-1 * suma)) / (1 + Math.Exp(-1 * suma));
            return y;
        }


    }

    class Neuron //: Warstwa
    {
        public double[] wagi = { 1, 1, 2, 3 };
        public double[] x = { 1, -1, -1, -1 };
        public double suma = 0;
        public int nr_neurona = 0;
        public int nr_warstwy = 0;
        


        public Neuron(double[] wagi,
                      double[] x,
                      int nr_warstwy,
                      int nr_neurona)
        {
            this.wagi = wagi;
            this.x = x;
            this.nr_warstwy = nr_warstwy;
            this.nr_neurona = nr_neurona;
        }

        public double net()
        {
            for (int i = 0; i < x.Length; i++)
            {
                suma += (x[i] * wagi[i]);
            }
            return suma;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double[] wagi = { 1, 1, 2, 3 };
            double[] x = { 1, -1, -1, -1 };
            double suma = 0;
            int nr_neurona = 0;

            //var neuron1 = new Neuron(wagi,x,1,nr_neurona);
            Warstwa w0 = new Warstwa(0,1,1,1);
            Console.WriteLine(w0.unipol(1));
            //Console.WriteLine(suma);
            Console.ReadLine();
        }
    }
}
