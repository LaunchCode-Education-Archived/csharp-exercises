using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CognitiveServices.SpeechRecognition;
using System.Media;
using System.IO;




namespace SpeechToTextApp
{
    class Program
    {
        static MicrophoneRecognitionClient _microRecogClient;

        static void Main(string[] args)
        {
            Console.WriteLine("Press enter to start your speech");
            Console.ReadLine();
            ConvertSpeechToText(SpeechRecognitionMode.LongDictation, "en-US", 
                "d4f6319baa234606991dc4d47e07c656");
        }

        public static void ConvertSpeechToText(SpeechRecognitionMode mode, string language, string subscriptionKey)
        {
            _microRecogClient = SpeechRecognitionServiceFactory.CreateMicrophoneClient(mode, language, subscriptionKey);
            _microRecogClient.OnResponseReceived += OnResponseReceivedHandler;
            _microRecogClient.OnPartialResponseReceived += OnPartialResponseReceivedHandler;
            _microRecogClient.OnConversationError += OnConversationError;
            _microRecogClient.StartMicAndRecognition();
        }

        static void OnConversationError(object sender, SpeechErrorEventArgs e)
        {
            Console.WriteLine("Error Code: {0}", e.SpeechErrorCode.ToString());
            Console.WriteLine("Error Text: {0}", e.SpeechErrorText);
            Console.WriteLine();
        }

        static void OnPartialResponseReceivedHandler(object sender, PartialSpeechResponseEventArgs e)
        {
            Console.WriteLine("{0} ", e.PartialResult);
            Console.WriteLine();
        }

        static void OnResponseReceivedHandler(object sender, SpeechResponseEventArgs e)
        {
            for (int i = 0; i < e.PhraseResponse.Results.Length; i++)
            {
                Console.Write("{0} ", e.PhraseResponse.Results[i].DisplayText);
            }
            Console.WriteLine();
        }
    }
}
