using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Samples
{
class Program
{
  delegate double DelegateToApply(double[] data);
  static void Main(string[] args)
  {
      double[] data = {
      147.8,137.4,125.2,141.1,145.7,
      119.9,133.3,142.3,138.7,125.7,
      142.0,130.8,129.8,141.2,134.9,
      125.0,128.9,142.0,118.6,133.0,
      151.1,125.7,126.3,140.9,138.9
		    };
      Console.WriteLine("\n CONJUNTO DE DATOS");
      Printf(data,5);
      Console.WriteLine("\n Reporte:\n");
      Console.WriteLine(" Media = {0}",GetOperation(data,d => {
	    double sum = 0.0;
      for (int i = 0; i < data.Length; i++)
	  sum += data[i];
      return sum / data.Length;
      }));
      Console.WriteLine(" Máximo = {0}",GetOperation(data,d =>{
	  double min = data[0];
      for(int i = 1;i < data.Length; i++)
	      if(data[i] < min)
		  min = data[i];
	  return min;
      }));
      Console.WriteLine(" Mínimo = {0}",GetOperation(data,d=>{
	  double max = data[0];
      for (int i = 1; i < data.Length; i++)
	  if (data[i] > max)
	      max = data[i];
      return max;
      }));
      Console.WriteLine("Presione cualquier tecla");
      Console.Read();
  }


  static double GetOperation(double[] data, DelegateToApply del) {
      return del(data);
  }
  
  static void Printf(double[] entries,int entrywidth){
      int size = entrywidth;
      for(int i = 0;i < entries.Length;i++){
	  Console.Write(" " + PadString(entries[i].ToString(), size));
	  if ((i + 1) % entrywidth == 0)
	      Console.WriteLine();
      }
  }

  static string PadString(string entry,int size) {
      StringBuilder buf = new StringBuilder(entry);
      int extra = size - entry.Length;
      for (int i = 0; i < extra; i++)
	  buf.Append(" ");
      return buf.ToString();
  }
}
}
