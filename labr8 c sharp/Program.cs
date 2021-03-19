using System;

namespace labr8_c_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            String ln;
            int groupn;
            double avgb1;
            double avgb2;
            int n;
            double sumofballs;
            double sumofballs1=0;
            Students sum1 = new Students {Value = 23 };// для перегрузки +
            Students sum2 = new Students {Value = 45 };// для перегрузки +
            Students counter = new Students() { Value = 10 };// для перегрузки ++
            Students student = new Students();
            Students[] students = new Students[3]; // массив объектов 
            Console.WriteLine("Введите кол-во студентов:");
             n = Convert.ToInt32(Console.ReadLine());
            


            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Введите Фамилию студента:");
                student.Name = Console.ReadLine();
                Console.WriteLine("Введите номер группы:");
                groupn = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите средный балл за 1 экзамен:");
                avgb1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите средный балл за 2 экзамен:");
                avgb2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите номер зачетки:");
                student.student_book.Set_id = Convert.ToInt32(Console.ReadLine());
                student.set_student(i, groupn, avgb1, avgb2);
                

            }

            Console.WriteLine("До сортировки:");
            student.outPut(n);
            Console.WriteLine("После сортировки:");
            student.sort(n);
            student.outPut(n);
            student.zadanie(n);
            student.Stipendia(n);
            student.stipendii_vivod(n);
           
            Console.WriteLine("Введите 3 студентов:");// массив объектов
            for (int i = 0; i < 3; i++)
            {

                students[i] = new Students();

            }

            for (int i = 0; i < 3; i++) {
              
                students[i].Set_last_name1(i, Console.ReadLine());

            }

            for (int i = 0; i < 3; i++)
            {

                Console.WriteLine($"Студент {i + 1}:{students[i].get_last_name1(i)}");

            }


            student.sum(n, out sumofballs,ref sumofballs1);
            Console.WriteLine($"Сумма баллов(out):{sumofballs}");
            Console.WriteLine($"Сумма баллов(ref):{sumofballs1}");
            Console.WriteLine("Работа со строками:\n");
            for (int i = 0; i < n; i++) 
            {
               Console.WriteLine($"фамилия:{student.getName(i)} длина:{ student.getName(i).Length}");
               Console.WriteLine( student.getName(i).ToUpper());
            
            }
            Students sum3 = sum1 + sum2;
            Console.WriteLine($"Перегрузка оператора +:{sum3.Value}");
            Console.WriteLine($"Перегрузка оператора ++:{(++counter).Value}");

        }
    }
    class Students
    {
        public const int M = 30;
        private static int bonus = 300;
        private static int stipendia = 2600;
        private static int[] fiplata = new int[M];
        int qw = 0;
        private String[] last_name = new String[M];
        private String[] last_name1 = new String[M];
        private int[] group = new int[M];
        private double[] avg_ball1 = new double[M];
        private double[] avg_ball2 = new double[M];
        public Student_book student_book = new Student_book();
        public int Value { get; set; }

        public static void Set_stipendia(int i,int q) {

            fiplata[i] = q;
        
        }

        public void Stipendia(int n) {
            int k;
           
            for (int i = 0; i < n; i++) { 
            
          

                if (((avg_ball1[i] + avg_ball2[i]) / 2 )>= 4 && ((avg_ball1[i] + avg_ball2[i]) / 2) < 4.5)
                {
                    k = Students.stipendia;
                    Set_stipendia(i, k);

                }

                if (((avg_ball1[i] + avg_ball2[i]) / 2) >= 4.5)
                {
                    k= Students.stipendia + Students.bonus;
                    Set_stipendia(i, k);

                }
                if(((avg_ball1[i] + avg_ball2[i]) / 2) < 4) {
                    k = 0;
                    Set_stipendia(i, k);
                }
               
            }
        
        }

        public  void stipendii_vivod(int n) {
            Students student = new Students();
            for (int i = 0; i < n; i++) {

                Console.WriteLine($"Студент:{last_name[i]} Стипендия:{fiplata[i]}");
            
            }
        
        }

      

        public String Name
        {
            set 
            {
                
                last_name[qw] = value;
                qw++;
                if (qw == (M - 1))
                {
                    qw = 0;
                }
            }


            
           
        
        
        }
        public String getName(int i) {

            return last_name[i];

        }

        public void Set_last_name1(int i,String last_name1) {

            this.last_name1[i] = last_name1;
        
        }
        public String get_last_name1(int i)
        {

            return last_name1[i];

        }

        public void set_student(int i, int group, double avg_ball1, double avg_ball2)
        {
            
            this.group[i] = group;
            this.avg_ball1[i] = avg_ball1;
            this.avg_ball2[i] = avg_ball2;
        }

        public void outPut(int n)
        {
            for (int i = 0; i < n; i++)
            {

                Console.WriteLine("{0} | {1} | {2} | {3} | {4}", last_name[i], group[i], avg_ball1[i], avg_ball2[i], student_book.get_id(i));

            }
        }

        public void sort(int n)
        {
            String ln;
            int gp;
            double ab1;
            double ab2;
            int Id, Id1;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = n - 1; j > i; j--)
                {

                    ln = last_name[j - 1];
                    last_name[j - 1] = last_name[j];
                    last_name[j] = ln;

                    gp = group[j - 1];
                    group[j - 1] = group[j];
                    group[j] = gp;

                    ab1 = avg_ball1[j - 1];
                    avg_ball1[j - 1] = avg_ball1[j];
                    avg_ball1[j] = ab1;

                    ab2 = avg_ball2[j - 1];
                    avg_ball2[j - 1] = avg_ball2[j];
                    avg_ball2[j] = ab2;

                    Id = student_book.get_id(j - 1);
                    Id1 = student_book.get_id(j);
                    student_book.set_id(j - 1, Id1);
                    student_book.set_id(j, Id);

                }
            }




        }

        public void zadanie(int n)
        {
            for (int i = 0; i < n; i++)
            {

                if (avg_ball2[i] < avg_ball1[i])
                {

                    Console.WriteLine("{0}", last_name[i]);

                }

            }


        }

     
        public void sum(int n,out double sumofballs,ref double sumofballs1)
        {
            double sum1, sum2;
            sum1 = 0;
            sum2 = 0;
            for (int i = 0; i < n; i++)
            {
                sum1 += avg_ball1[i];
                sum2 += avg_ball2[i];
            }

            Console.WriteLine("Sum1:{0}", sum1);
            Console.WriteLine("Sum2:{0}", sum2);
            sumofballs = sum1 + sum2;
            sumofballs1 = sum1 + sum2;

        }

        public static Students operator +(Students sum1,Students sum2)
            {
 
             return new Students { Value = sum1.Value + sum2.Value };
 
            }

        public static Students operator ++(Students counter) 
        {

            return new Students { Value = counter.Value + 10 };
        
        }
       public class Student_book
        {
            public const int M = 30;

            private int[] id = new int[M];
            int i = 0;
            public int Set_id
            {


                set
                {

                    id[i] = value;
                    i++;
                    if (i == (M - 1))
                    {
                        i = 0;
                    }


                }



            }



            public void set_id(int i, int id1)
            {

                id[i] = id1;

            }

            public int get_id(int i)
            {

                return id[i];

            }

        }
    }

   
}
