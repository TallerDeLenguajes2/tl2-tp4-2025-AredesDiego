using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
public class AccesoADatosJSON<T> : IAccesoADatos<T>
{
    public List<T> Cargar(string archivo)
    {
        Console.WriteLine($"Intentando cargar: {archivo}");
        Console.WriteLine($"Archivo existe: {File.Exists(archivo)}");

        if (!File.Exists(archivo))
        {
            Console.WriteLine($"Archivo no encontrado: {archivo}");
            return new List<T>();
        }

        try
        {
            string json = File.ReadAllText(archivo);
            Console.WriteLine($"JSON leído: {json}");
            var result = JsonSerializer.Deserialize<List<T>>(json) ?? new List<T>();
            Console.WriteLine($"Elementos deserializados: {result.Count}");
            return result;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error deserializando: {ex.Message}");
            return new List<T>();
        }
    }

    public void Guardar(List<T> datos, string ruta)
    {
        try
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(datos, options);
            Console.WriteLine($"Guardando JSON: {json}");
            File.WriteAllText(ruta, json);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error guardando: {ex.Message}");
        }
    }
}