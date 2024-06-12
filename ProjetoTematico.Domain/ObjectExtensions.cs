using System.Reflection;

namespace ProjetoTematico.Domain;

public static class ObjectExtensions
{
    public static TTarget MapTo<TTarget>(this object source) where TTarget : new()
    {
        if (source == null) throw new ArgumentNullException(nameof(source));

        var sourceType = source.GetType();
        var targetType = typeof(TTarget);

        var targetInstance = new TTarget();

        foreach (var sourceProp in sourceType.GetProperties(BindingFlags.Public | BindingFlags.Instance))
        {
            var targetProp = targetType.GetProperty(sourceProp.Name, BindingFlags.Public | BindingFlags.Instance);
            if (targetProp != null && targetProp.CanWrite && targetProp.PropertyType == sourceProp.PropertyType)
            {
                var value = sourceProp.GetValue(source, null);
                targetProp.SetValue(targetInstance, value, null);
            }
        }

        return targetInstance;
    }

    /// <summary>
    /// Cria uma nova lista de objetos do tipo TTarget e copia os dados de cada item da lista "source" para novos objetos.
    /// Retorna a nova lista criada.
    /// </summary>
    public static List<TTarget> MapToList<TSource, TTarget>(this IEnumerable<TSource> source) where TTarget : new()
    {
        if (source == null) throw new ArgumentNullException(nameof(source));

        var targetList = new List<TTarget>();

        foreach (var item in source)
        {
            targetList.Add(item.MapTo<TTarget>());
        }

        return targetList;
    }
}
