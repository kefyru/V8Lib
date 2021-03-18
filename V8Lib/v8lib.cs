using System;
using System.Runtime.InteropServices;

// [assembly: ComVisible(true)]

namespace V8Lib

{
  // /// <summary>
  // /// 
  // /// </summary>
  // [ComVisible(true)]
  // [Guid()]
  // internal interface IMyClass
  //
  // {
  //   /// <summary>
  //   /// 
  //   /// </summary>
  //   /// <param name="msg"></param>
  //   /// <returns></returns>
  //   [DispId(1)]
  //   string Hello(string msg);
  // }


  // /// <summary>
  // /// 
  // /// </summary>
  // [ComVisible(true)]
  // [
  //   Guid(),
  //   InterfaceType(ComInterfaceType.InterfaceIsIDispatch)
  // ]
  // public interface IMyEvents { }


  /// <summary>
  /// 
  /// </summary>
  [ComVisible(true)]
  [ProgId("Dispatcher")]
  [ClassInterface(ClassInterfaceType.AutoDispatch)]
  [Guid("991290EF-D246-478E-9724-FFABDB368D2E")]
  public class Dispatcher
  {
    /// <summary>
    /// Создать новый объект заданного типа
    /// </summary>
    /// <param name="имяТипа">Тип: строка, имя типа создаваемого объекта</param>
    /// <returns>Объект указанного типа</returns>
    [ComVisible(true)]
    public object Создать(string имяТипа) => Create(имяТипа);

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