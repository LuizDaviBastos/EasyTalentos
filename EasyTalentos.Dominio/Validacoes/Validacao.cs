using System;
using System.Linq;

namespace EasyTalentos.Dominio.Validacoes
{
    public class Validacao
    {

        public static bool IsValid(object obj)
        {
            if (obj == null) return false;

            bool valido = true;

            //Percorre todas as propriedades do objeto em busca do atributo "Requirido"
            Array.ForEach(obj.GetType().GetProperties(), p =>
            {
                var attribute = p.GetCustomAttributes(false)
                .Where(a => a.GetType() == typeof(Requirido))
                .FirstOrDefault();

                /* Caso encontre, faz a validação da propriedade. */
                if (attribute != null)
                {
                    object value = p.GetValue(obj);
                    if (value == null)
                    {
                        valido = false;
                        return;
                    }

                    if (int.TryParse(value.ToString(), out int number))
                    {
                        if (number <= 0)
                        {
                            valido = false;
                            return;
                        }
                    }

                    if (string.IsNullOrEmpty(value.ToString())) valido = false;

                }
            });

            return valido;
        }

    }

    //Atributos usados apenas para anotações de propriedade
    public class Requirido : Attribute { }
}
