class Matrix
{
  public static double[,] Multiply(double[,] matrix1, double[,] matrix2) {  
  // cahing matrix lengths for better performance  
  var matrix1Rows = matrix1.GetLength(0);  
  var matrix1Cols = matrix1.GetLength(1);  
  var matrix2Rows = matrix2.GetLength(0);  
  var matrix2Cols = matrix2.GetLength(1);  
  
  // checking if product is defined  
  if (matrix1Cols != matrix2Rows)  
    throw new InvalidOperationException  
      ("Product is undefined. n columns of first matrix must equal to n rows of second matrix");  
  
  // creating the final product matrix  
  double[,] product = new double[matrix1Rows, matrix2Cols];  
  
  // looping through matrix 1 rows  
  for (int matrix1_row = 0; matrix1_row < matrix1Rows; matrix1_row++) {  
    // for each matrix 1 row, loop through matrix 2 columns  
    for (int matrix2_col = 0; matrix2_col < matrix2Cols; matrix2_col++) {  
      // loop through matrix 1 columns to calculate the dot product  
      for (int matrix1_col = 0; matrix1_col < matrix1Cols; matrix1_col++) {  
        product[matrix1_row, matrix2_col] +=   
          matrix1[matrix1_row, matrix1_col] *   
          matrix2[matrix1_col, matrix2_col];  
      }  
    }  
  }  
  
  return product;  
}

}

struct HomePoint//структура для однородных координат
{
  public double x,y,w;

  public HomePoint(double x,double y,double w=1)
  {
    this.x=x;
    this.y=y;
    this.w=w;
  }

  public HomePoint(double[,] matrix)
  {
    this.x=matrix[0,0];
    this.y=matrix[1,0];
    this.w=matrix[2,0];
  }

  public double[,] GetMatrix()
  {
    return new double[,] {{x,0},{y,0},{w,0}};
  }

  public override string ToString()
  {
    return $"({x},{y},{w})";    
  }
}

class Program
{
  static void Main()
  {

  int k=10;
  double[,] scaleMatrix=new double[2,2];
  scaleMatrix[0,0]=k;
  scaleMatrix[1,1]=k;
  //точки фигуры
  HomePoint[] points=new HomePoint[3];
  points[0]=new HomePoint(1,1,1);
  points[1]=new HomePoint(3,1,1);
  points[2]=new HomePoint(2,2,1);
  System.Console.WriteLine("Points before scale");
  foreach(HomePoint point in points)
    System.Console.WriteLine(point);
    System.Console.WriteLine("Points after scale");
  for(int i=0;i<points.Length;i++)
    System.Console.WriteLine(new HomePoint(Matrix.Multiply(points[i].GetMatrix(),scaleMatrix)));

  }
}