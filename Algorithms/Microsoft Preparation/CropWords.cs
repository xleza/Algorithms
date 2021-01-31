using System.Text;

namespace Algorithms
{
    public static class CropWords
    {
        public static string Execute(string message, int k)
        {
            var messageToCrop = new StringBuilder(message);
            TrimEnd(messageToCrop);

            while (messageToCrop.Length > k)
            {
                RemoveLastWord(messageToCrop);
                TrimEnd(messageToCrop);
            }

            return messageToCrop.ToString();
        }

        private static void TrimEnd(StringBuilder message)
        {
            while (message.Length > 0 && message[message.Length - 1] == ' ')
            {
                message.Remove(message.Length - 1, 1);
            }
        }

        private static void RemoveLastWord(StringBuilder message)
        {
            while (message.Length > 0 && message[message.Length - 1] != ' ')
            {
                message.Remove(message.Length - 1, 1);
            }
        }
    }
}
