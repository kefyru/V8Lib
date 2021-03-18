using System;
using System.Runtime.InteropServices;

[assembly: ComVisible(true)]

namespace VLib

{
  /// <summary>
  /// 
  /// </summary>
  [ComVisible(true)]
  [Guid("9980DE0D-B0FC-4334-9F15-1404F13D110D")]
  internal interface IWrapper
  
  {
    /// <summary>
    /// 
    /// </summary>
    /// <param name="msg"></param>
    /// <returns></returns>
    [DispId(1)]
    object Create(string msg);
  }
  

  /// <summary>
  /// 
  /// </summary>
  [ComVisible(true)]
  [
    Guid("10C32A08-FB4D-467A-8E0C-B0DC3ADFF84F"),
    InterfaceType(ComInterfaceType.InterfaceIsIDispatch)
  ]
  public interface IMyEvents { }


  /// <summary>
  /// 
  /// </summary>
  [ComVisible(true)]
  [ProgId("Wrapper")]
  [ClassInterface(ClassInterfaceType.AutoDispatch)]
  [Guid("74C4FBD7-3560-4F9C-B4FC-EE9003896F60")]
  public class Wrapper: IWrapper
  {
    // /// <summary>
    // /// Создать новый объект заданного типа
    // /// </summary>
    // /// <param name="имяТипа">Тип: строка, имя типа создаваемого объекта</param>
    // /// <returns>Объект указанного типа</returns>
    // [ComVisible(true)]
    // public object Создать(string имяТипа) => Create(имяТипа);

    /// <summary>
    /// Create new object of type
    /// </summary>
    /// <param name="typeName">Type: string, name of type</param>
    /// <returns>Object of type</returns>
    [ComVisible(true)]
    public object Create(string typeName)
    {
      try
      {
        var type = Type.GetType(typeName);
        if (type is null) throw new Exception($"Тип \"{typeName}\" не найден.");
        return Activator.CreateInstance(type);
      }
      catch (Exception e)
      {
        throw new Exception($"Ошибка создания объекта \"{typeName}\" \n{e.Message}");
      }
    }
  }
}