// 
// Created by the DataSnap proxy generator.
// 25/07/2014 15:07:47
// 

using System;
using System.Threading;

namespace Embarcadero.Datasnap.WindowsPhone7
{
  public class DSProxy
  {
    public class TServerMethods1 : DSAdmin
    {
      public TServerMethods1(DSRESTConnection Connection, ExceptionCallback ExCal)
          : base(Connection, ExCal)
      {
      }

      private DSRESTParameterMetaData[] TServerMethods1_EchoString_Metadata;
      private DSRESTParameterMetaData[] get_TServerMethods1_EchoString_Metadata()
      {
        if (TServerMethods1_EchoString_Metadata == null)
        {
          TServerMethods1_EchoString_Metadata = new DSRESTParameterMetaData[]
          {
            new DSRESTParameterMetaData("Value", DSRESTParamDirection.Input, DBXDataTypes.WideStringType, "string"),
            new DSRESTParameterMetaData("", DSRESTParamDirection.ReturnValue, DBXDataTypes.WideStringType, "string"),
          };
        }
        return TServerMethods1_EchoString_Metadata;
      }

      /**
       * @param Value [in] - Type on server: string
       * @return result - Type on server: string
       */
      public delegate void EchoStringCallback(String Result);

      public void EchoString(String Value, EchoStringCallback callback = null, ExceptionCallback ExCal = null)
      {
        DSRESTCommand cmd = getConnection().CreateCommand();
        cmd.setRequestType(DSHTTPRequestType.GET);
        cmd.setText("TServerMethods1.EchoString");
        cmd.prepare(get_TServerMethods1_EchoString_Metadata());
        InternalConnectionDelegate EchoStringDel = () =>
        {
          if (callback != null)
          {
            try
            {
              callback.DynamicInvoke(cmd.getParameter(1).getValue().GetAsString());
            }
            catch (Exception ex)
            {
              if (ExCal != null) getConnection().syncContext.Send(new SendOrPostCallback(x => ExCal.DynamicInvoke(ex.InnerException)), null);
              else getConnection().syncContext.Send(new SendOrPostCallback(x => BaseExCal.DynamicInvoke(ex.InnerException)), null);
            }
          }
        };
        cmd.getParameter(0).getValue().SetAsString(Value);
        getConnection().execute(cmd, this, EchoStringDel, ExCal);
      }
      private DSRESTParameterMetaData[] TServerMethods1_ReverseString_Metadata;
      private DSRESTParameterMetaData[] get_TServerMethods1_ReverseString_Metadata()
      {
        if (TServerMethods1_ReverseString_Metadata == null)
        {
          TServerMethods1_ReverseString_Metadata = new DSRESTParameterMetaData[]
          {
            new DSRESTParameterMetaData("Value", DSRESTParamDirection.Input, DBXDataTypes.WideStringType, "string"),
            new DSRESTParameterMetaData("", DSRESTParamDirection.ReturnValue, DBXDataTypes.WideStringType, "string"),
          };
        }
        return TServerMethods1_ReverseString_Metadata;
      }

      /**
       * @param Value [in] - Type on server: string
       * @return result - Type on server: string
       */
      public delegate void ReverseStringCallback(String Result);

      public void ReverseString(String Value, ReverseStringCallback callback = null, ExceptionCallback ExCal = null)
      {
        DSRESTCommand cmd = getConnection().CreateCommand();
        cmd.setRequestType(DSHTTPRequestType.GET);
        cmd.setText("TServerMethods1.ReverseString");
        cmd.prepare(get_TServerMethods1_ReverseString_Metadata());
        InternalConnectionDelegate ReverseStringDel = () =>
        {
          if (callback != null)
          {
            try
            {
              callback.DynamicInvoke(cmd.getParameter(1).getValue().GetAsString());
            }
            catch (Exception ex)
            {
              if (ExCal != null) getConnection().syncContext.Send(new SendOrPostCallback(x => ExCal.DynamicInvoke(ex.InnerException)), null);
              else getConnection().syncContext.Send(new SendOrPostCallback(x => BaseExCal.DynamicInvoke(ex.InnerException)), null);
            }
          }
        };
        cmd.getParameter(0).getValue().SetAsString(Value);
        getConnection().execute(cmd, this, ReverseStringDel, ExCal);
      }
      private DSRESTParameterMetaData[] TServerMethods1_SayHello_Metadata;
      private DSRESTParameterMetaData[] get_TServerMethods1_SayHello_Metadata()
      {
        if (TServerMethods1_SayHello_Metadata == null)
        {
          TServerMethods1_SayHello_Metadata = new DSRESTParameterMetaData[]
          {
            new DSRESTParameterMetaData("nome", DSRESTParamDirection.Input, DBXDataTypes.WideStringType, "string"),
            new DSRESTParameterMetaData("", DSRESTParamDirection.ReturnValue, DBXDataTypes.WideStringType, "string"),
          };
        }
        return TServerMethods1_SayHello_Metadata;
      }

      /**
       * @param nome [in] - Type on server: string
       * @return result - Type on server: string
       */
      public delegate void SayHelloCallback(String Result);

      public void SayHello(String nome, SayHelloCallback callback = null, ExceptionCallback ExCal = null)
      {
        DSRESTCommand cmd = getConnection().CreateCommand();
        cmd.setRequestType(DSHTTPRequestType.GET);
        cmd.setText("TServerMethods1.SayHello");
        cmd.prepare(get_TServerMethods1_SayHello_Metadata());
        InternalConnectionDelegate SayHelloDel = () =>
        {
          if (callback != null)
          {
            try
            {
              callback.DynamicInvoke(cmd.getParameter(1).getValue().GetAsString());
            }
            catch (Exception ex)
            {
              if (ExCal != null) getConnection().syncContext.Send(new SendOrPostCallback(x => ExCal.DynamicInvoke(ex.InnerException)), null);
              else getConnection().syncContext.Send(new SendOrPostCallback(x => BaseExCal.DynamicInvoke(ex.InnerException)), null);
            }
          }
        };
        cmd.getParameter(0).getValue().SetAsString(nome);
        getConnection().execute(cmd, this, SayHelloDel, ExCal);
      }
    }

  }
}
