// try catch finally throw

namespace ExploringTheNet.src.SessionFour.AppException;

using System;

public static class RunAppException {
    public static void RunTryCatch() {
        AppTryCatch.ZeroDivision();
        Console.WriteLine("------");
        AppTryCatch.CheckRange();
    }
}
