using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Engine.Errors.Basic;
using Engine.Errors.Critical;
using Engine.Errors.Warming;

namespace Engine.Errors
{
    enum ErrorType
    {
        Basic,
        Warming,
        Critical,
    }
    class ErrorManager
    {
        public static void PrintError(ErrorType TypeOfError, string ErrorMessage)
        {
            if(TypeOfError == ErrorType.Basic)
            {
                if(ErrorMessage == "")
                {
                    BasicError F_ErrorBasic = new BasicError();
                    F_ErrorBasic.ErrorMessage = "Unknow error";
                    F_ErrorBasic.ShowDialog();
                }
                else
                {
                    BasicError F_ErrorBasic = new BasicError();
                    F_ErrorBasic.ErrorMessage = ErrorMessage;
                    F_ErrorBasic.ShowDialog();
                }
            }

            if (TypeOfError == ErrorType.Warming)
            {
                if (ErrorMessage == "")
                {
                    WarmingError F_WarmingError = new WarmingError();
                    F_WarmingError.ErrorMessage = "Unknown error";
                    F_WarmingError.ShowDialog();
                }
                else
                {
                    WarmingError F_WarmingError = new WarmingError();
                    F_WarmingError.ErrorMessage = ErrorMessage;
                    F_WarmingError.ShowDialog();
                }
            }

            if (TypeOfError == ErrorType.Critical)
            {
                if (ErrorMessage == "")
                {
                    CriticalError F_CriticalError = new CriticalError();
                    F_CriticalError.ErrorMessage = "Unknown error";
                    F_CriticalError.ShowDialog();
                }
                else
                {
                    CriticalError F_CriticalError = new CriticalError();
                    F_CriticalError.ErrorMessage = ErrorMessage;
                    F_CriticalError.ShowDialog();
                }
            }
        }
    }
}
