# BruteForceTool

## Main Idea
The purpose of this tool is purely educational, specifically for learning about cybersecurity concepts.
It is **strictly prohibited** to use this tool for any illegal or unethical activities.

By using this software, you agree to use it responsibly and only in environments where you have explicit permission.

## Features
- **Brute Force Attack Simulation**: The tool simulates a brute-force attack, attempting to guess passwords based on a predefined set of characters.
- **Educational Purpose**: The tool's design and implementation are simplified to aid in learning how brute-force attacks function.
- **Limited Scope**: The tool is limited to testing passwords of 3 characters in length and restricted to a range of characters (digits 1-3 and letters a-c), ensuring that it cannot be used to attack more complex passwords or systems.

## Usage
To use this tool:
1. Clone or download the repository:
   ```bash
   git clone https://github.com/kamashi999/BruteForceTool.git
2. Open the project in a C# development environment (such as Visual Studio).
3. Run the program. It will attempt to brute-force a password using a specified character range.
4. Modify the password variables as desired to experiment with different password lengths.

## Example configuration
string password = "2c3"; // The target password.

## Ethical Use Disclaimer
The tool should only be used in controlled, ethical environments, such as personal or lab setups

Do NOT use this tool on any system or account you do not own or have explicit permission to test. Unauthorized use of brute-force tools on systems you do not control is illegal and unethical.

## Limitations
- Password Length: This tool is limited to brute-forcing passwords of a maximum length of 3 characters.
- Character Range: The range of characters is limited to digits (1-3) and lowercase letters (a-c).
- No Real-World Application: The tool is intentionally simple and designed to demonstrate a basic brute-force approach. It is not intended for use in real-world penetration testing or security auditing.
