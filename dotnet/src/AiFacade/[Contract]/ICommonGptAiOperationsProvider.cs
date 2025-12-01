using System;

namespace AI.KornSW {

  public interface ICommonGptAiOperationsProvider {

    string CallWebSearchApi(string prompt, object inputData = null);
    T CallWebSearchApi<T>(string prompt, object inputData = null) where T : class;

    byte[] CallImageEditApi(byte[] inputImageBytes, string prompt, byte[] maskImageBytes = null);
    byte[] CallImageGeneratorApi(string prompt);

  }

}
