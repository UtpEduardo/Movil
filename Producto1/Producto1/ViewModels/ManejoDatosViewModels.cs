using System;
using System.Collections.Generic;
using System.Text;

using System.Collections.ObjectModel;
using System.IO;
using Producto1.Models;
using System.Reflection;

namespace Producto1.ViewModels
{
    public class ManejoDatosViewModels
    {        
        public ObservableCollection<Medicamentos> Medicamento { set; get; }
       // string permos = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData));

        public ManejoDatosViewModels()
        {
            //if (!File.Exists(this.permos))
            //    File.WriteAllText(this.permos, "");

            Medicamento = new ObservableCollection<Medicamentos>();

            Assembly archivo = IntrospectionExtensions.GetTypeInfo(typeof(Medicamentos)).Assembly;
            Stream s = archivo.GetManifestResourceStream("Producto1.Models.medicamentos.txt");
            StreamReader sr = new StreamReader(s);
            string text = sr.ReadToEnd();
            string[] lineas = text.Split('\n');
            while (!sr.EndOfStream)
            {
                
                for (int i = 0; i < lineas.Length - 1; i++)
                {
                    Medicamento.Add(new Medicamentos
                    {
                        ID = int.Parse(lineas[i].ToString().Replace("\r", "")),
                        Nombre = lineas[i + 1].ToString().Replace("\r", ""),
                        Presentacion = lineas[i + 2].ToString().Replace("\r", ""),
                        FechaCaducida = Convert.ToDateTime(lineas[i + 3].ToString().Replace("\r", "")),
                        Precio = Convert.ToDouble(lineas[i + 4].ToString().Replace("\r", "")),
                        Imagen = lineas[i + 5].ToString().Replace("\r", ""),
                        Promocion = Convert.ToBoolean(lineas[i + 6].ToString().Replace("\r", ""))
                    });
                    i++;
                }
            }
            sr.Close();
        }
        public ObservableCollection<Medicamentos> ObtenerMedicinas()
        {
            return Medicamento;
        }

        public ObservableCollection<Medicamentos> ConsultaCaducidad(DateTime fecha)
        {
            ObservableCollection<Medicamentos> consulta= new ObservableCollection<Medicamentos>();
            for (int i = 0; i < Medicamento.Count; i++)
            {
                if (Medicamento[i].FechaCaducida == fecha)
                {
                    consulta.Add(new Medicamentos
                    {
                        Nombre = Medicamento[i].Nombre,
                        Presentacion = Medicamento[i].Presentacion,
                        FechaCaducida = Convert.ToDateTime(Medicamento[i].FechaCaducida),
                        Precio = Convert.ToDouble(Medicamento[i].Precio),
                        Imagen = Medicamento[i].Imagen,
                    });
                }
            }
            return consulta;
        }

        public ObservableCollection<Medicamentos> ConsultaNom(string nombre)
        {
            ObservableCollection<Medicamentos> consulta = new ObservableCollection<Medicamentos>();
            for (int i = 0; i < Medicamento.Count; i++)
            {
                if (Medicamento[i].Nombre == nombre)
                {
                    consulta.Add(new Medicamentos
                    {
                        Nombre = Medicamento[i].Nombre,
                        Presentacion = Medicamento[i].Presentacion,
                        Precio = Convert.ToDouble(Medicamento[i].Precio),
                        Imagen = Medicamento[i].Imagen
                    });
                }
            }
            return consulta;
        }

        public ObservableCollection<Medicamentos> ConsultaPres(string presnta)
        {
            ObservableCollection<Medicamentos> consulta = new ObservableCollection<Medicamentos>();
            for (int i = 0; i < Medicamento.Count; i++)
            {
                if (Medicamento[i].Presentacion == presnta)
                {
                    consulta.Add(new Medicamentos
                    {
                        Nombre = Medicamento[i].Nombre,
                        Presentacion = Medicamento[i].Presentacion,
                        Precio = Convert.ToDouble(Medicamento[i].Precio),
                        Imagen = Medicamento[i].Imagen
                    });
                }
            }
            return consulta;
        }
    }
}
