using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CybersecurityChatbot
{
    internal class CyberBot
    {
        private string userName;

        public void StartChat()
        {
            Console.WriteLine("\n==============================================================================================");
            Console.WriteLine("                              Cybersecurity Awareness Chatbot");
            Console.WriteLine("==============================================================================================\n");

            Console.WriteLine("Hello there! Hope you are doing amazing today :)");
            Console.Write("Please enter your full name: ");
            userName = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Green;
            TypeResponse($"\nWelcome, {userName}! I'm your Cybersecurity Awareness Assistant\nCall me the... !!CYBERLOCK GUARD!! <^>");
            Console.WriteLine("**********************************************************************************************" +
                "\nFeel free to ask me anything about staying safe online :)");
            Console.ResetColor();

            Console.WriteLine("\nYou can ask me questions like:");
            Console.WriteLine("- How are you?\n- What's your purpose?\n- What can I ask you about?\n- Tell me about password safety\n- What is phishing?\n- How do I browse safely?");
            Console.WriteLine("- What is malware?\n- What should I do if I'm hacked?\n- What is a firewall?\n- Why are software updates important?\n- How do I create a strong password?");
            Console.WriteLine("\nTo end chat enter 'exit' or 'quit'.");

            bool keepChatting = true;

            while (keepChatting)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\nYou: ");
                Console.ResetColor();

                string userInput = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(userInput))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Cyberlock: Please enter something for me to respond to!!!");
                    Console.ResetColor();
                    continue;
                }

                userInput = userInput.Trim().ToLower();

                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("Cyberlock is typing...");
                Thread.Sleep(400);
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Cyan;
                switch (userInput)
                {
                    case "how are you?":
                        TypeResponse("I'm fully patched and running smoothly! Thanks for asking. ;) I’m always on guard to keep you safe!");
                        break;

                    case "what's your purpose?":
                        TypeResponse("I'm here to empower you with cybersecurity knowledge and help you protect your digital world from threats.");
                        break;

                    case "what can i ask you about?":
                        TypeResponse("You can ask me about phishing, password safety, malware, firewalls, software updates, and more.");
                        break;

                    case "tell me about password safety":
                        TypeResponse("Passwords should be long and complex — at least 12 characters. Use numbers, symbols, and upper/lowercase letters. Avoid personal info like birthdays.");
                        ShowRandomCyberTip();
                        break;

                    case "what is phishing?":
                        TypeResponse("Phishing is a cyberattack where criminals pretend to be trustworthy sources to steal your personal info. Always double-check links and emails before clicking.");
                        ShowRandomCyberTip();
                        break;

                    case "how do i browse safely?":
                        TypeResponse("Use trusted websites, look for 'https' in the URL, and avoid downloading files or clicking popups from unknown sources. Also, use privacy-focused browsers when possible.");
                        ShowRandomCyberTip();
                        break;

                    case "what is malware?":
                        TypeResponse("Malware is any software designed to harm your computer or steal your data. It includes viruses, spyware, trojans, and more. Keep your antivirus up to date!");
                        ShowRandomCyberTip();
                        break;

                    case "what should i do if i'm hacked?":
                        TypeResponse("Change your passwords immediately, enable two-factor authentication, and scan your devices with security software. Alert your bank or contacts if needed.");
                        ShowRandomCyberTip();
                        break;

                    case "what is a firewall?":
                        TypeResponse("A firewall acts like a digital security guard — it monitors incoming and outgoing network traffic and blocks threats before they reach you.");
                        ShowRandomCyberTip();
                        break;

                    case "why are software updates important?":
                        TypeResponse("Updates often include patches for new security holes. If you delay them, hackers can exploit those weaknesses to gain access to your data.");
                        ShowRandomCyberTip();
                        break;

                    case "how do i create a strong password?":
                        TypeResponse("Use a mix of letters, numbers, and symbols. Avoid dictionary words. For example: 'B3@chW4lker!2025'. Also, use a password manager to keep track.");
                        ShowRandomCyberTip();
                        break;

                    case "exit":
                    case "quit":
                        TypeResponse($"Stay safe out there, {userName}! <^> Goodbye.");
                        keepChatting = false;
                        break;

                    default:
                        TypeResponse("I'm sorry I didn’t quite understand that. Could you rephrase or try a different question?");
                        break;
                }

                Console.ResetColor();
            }
        }

        private void TypeResponse(string message, int delay = 15)
        {
            Console.Write("Cyberlock: ");
            foreach (char c in message)
            {
                Console.Write(c);
                Thread.Sleep(delay);
            }
            Console.WriteLine();
        }

        private void ShowRandomCyberTip()
        {
            string[] tips = {
                "General Tip: Always use 2-factor authentication on your accounts.",
                "General Tip: Never reuse the same password across sites.",
                "General Tip: Watch out for fake giveaways on social media.",
                "General Tip: Use antivirus software and keep it up to date.",
                "General Tip: Don’t plug in unknown USB devices — they can carry malware!",
                "General Tip: Regularly back up your data in case of ransomware attacks.",
                "General Tip: Think before you click — even on social media links.",
            };

            Random rnd = new Random();
            int index = rnd.Next(tips.Length);

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            TypeResponse(tips[index], 15);
            Console.ResetColor();
        }
    }
}