# Cyberlock Guard – Cybersecurity Awareness Chatbot

Cyberlock Guard is a beginner-friendly, voice-greeting, command-line chatbot built in **C#** to help South African citizens become more aware of cybersecurity threats and how to stay safe online.

> “Call me the... **CYBERLOCK GUARD**!” 

---

## Features

- **Plays a voice greeting** when launched
- ASCII art logo and colorful terminal UI
- Handles multiple cybersecurity questions like:
  - What is phishing?
  - Tell me about password safety
  - How do I browse safely?
  - What are common scams?
  - What is malware?
- Simulated typing effect for more natural conversation
- Random cybersecurity safety tips provided after answers
- Exit the chatbot anytime by typing `exit` or `quit`

---

## Purpose

This chatbot was developed as part of my **Cybersecurity Awareness Portfolio of Evidence (POE)** to promote safer digital behavior in South African communities by providing simple and helpful advice on:

- Password safety
- Phishing scams
- Safe browsing
- Malware threats
- Common online scams

---

## Getting Started

### Requirements

- [Visual Studio 2022](https://visualstudio.microsoft.com/)
- .NET 6.0 or later
- Windows OS (for audio playback using `SoundPlayer`)

### Run the chatbot

1. Clone or download this repository.
2. Open the solution in Visual Studio 2022.
3. Make sure your `greeting.wav` file is placed in a folder named `Cassidy` (set its **Copy to Output Directory** to `Copy always`).
4. Run the program using `F5`.

---

## Folder Structure

Cyberlock-Assistant/
├── Cassidy/
│ └── greeting.wav # Voice greeting played at launch
├── CyberBot.cs # Main chatbot logic
├── Program.cs # Entry point
├── README.md # Project overview (this file)

---

## Example Interaction

```plaintext
Hello there! Hope you are doing amazing today :)
Please enter your full name: Asanda Dimba

Welcome, Asanda Dimba! I'm your Cybersecurity Awareness Assistant
Call me the... !!CYBERLOCK GUARD!! <^>
Feel free to ask me anything about staying safe online :)

You: what is phishing?
Cyberlock is typing...
Phishing is when scammers trick you into giving personal info by pretending to be someone you trust, like your bank.
General Tip: Watch out for fake giveaways on social media.

---

**## License**
This project is for educational purposes.


