using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace QuizzFarmacia1.Models
{
    public class BussinesM
    {

   List<empleados> farList;
   public BussinesM(string dbPath) 
            
        {
           

            farList = new List<empleados>();
            
            
            var reader = new StreamReader(
                File.OpenRead(dbPath));

            
            while (!reader.EndOfStream)
            {
                
                var line = reader.ReadLine();
 
                
                var valores = line.Split(',');
                farList.Add(
                    new empleados
                    {
                        NumEmpleado = valores[0],
                        NomEmpleado = valores[1],
                        AreaEmpleado = valores[2],
                        Telefono= valores[3],
                        Email = valores[4],
                        Photo = valores[5]
                    }
                  );                    
                      
            }


        }

        
        public empleados GetEmployeeById(string NumEmpleado )
        {
            var Empleados = farList.Find(e => e.NumEmpleado == NumEmpleado);
            return Empleados;

        }

    }
}