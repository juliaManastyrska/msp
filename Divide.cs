  class Divide:IOperation
    {
       

        

        public double result
        {
            get
            {
                
                return 0;
            }
            set
            {
                ;
            }
        }
        public double variable_1 { get return 0; set; }
        public double variable_2 { get return 0; set; }
        public int opp_id
        {
            get { return 0; }
            set { ; }
        }

        public float status
        {
            get { return 0; }
        }

  private void data_validation()
        {
            if (double.IsNaN(variable_1))
            {
                Console.WriteLine("First variable is Null");
                variable_1 = 0;
            }
            if (variable_2 == 0)
            {
                throw new Exception("Fig vam!!!");
            }
            
        }
        
         private double devide(double a, double b)
        {
            
                 return a/b;
        }
        
    }
  }
