# Mental Math Trainer

Mental Math Trainer is a minimalistic educational Android app designed to help users practice timed arithmetic skills, including Addition, Subtraction, Multiplication, and Division. Developed using the Unity engine, this repository includes all necessary files and resources to build, run, and modify the app, aiming to improve users' mental math skills.

## Table of Contents
- [Introduction](#introduction)
- [Features](#features)
- [Installation](#installation)
- [Usage](#usage)
- [Project Structure](#project-structure)
- [Gameplay](#gameplay)
- [Controls](#controls)
- [Scripts Overview](#scripts-overview)
  - [GameController.cs](#gamecontrollercs)
  - [QuizController.cs](#quizcontrollercs)
  - [UIController.cs](#uicontrollercs)
- [Contributing](#contributing)
- [License](#license)
- [Contact](#contact)

## Introduction

Mental Math Trainer is a minimalistic Mental Math Trainer app that provides users with timed exercises to practice arithmetic skills such as Addition, Subtraction, Multiplication, and Division. The app is designed to improve mental math skills in a simple and engaging way.


<div style="display: flex; justify-content: space-between;">
  <img src="Game%20Screenshot/MT%20(4).jpeg" alt="Game Screenshot 4" style="width: 32%;">
  <img src="Game%20Screenshot/MT%20(5).jpeg" alt="Game Screenshot 5" style="width: 32%;">
  <img src="Game%20Screenshot/MT%20(6).jpeg" alt="Game Screenshot 6" style="width: 32%;">
</div>

## Features

- **Timed Exercises:** Practice arithmetic skills with timed exercises.
- **Four Operations:** Includes Addition, Subtraction, Multiplication, and Division.
- **Progress Tracking:** Track your progress and see your improvement over time.
- **Minimalistic Design:** Clean and intuitive UI design.
- **Immersive Sound Effects:** Enhance the learning experience with sound effects.

## Installation

To set up and run the project locally, follow these steps:

### Prerequisites

- Unity Hub installed.
- Unity Editor version 2020.3.0f1 or later.
- Android SDK configured.

### Steps

1. Clone the repository:

    ```sh
    git clone https://github.com/adibakshi28/Mental_Math_Trainer.git
    ```

2. Open the project in Unity:
    - Open Unity Hub.
    - Click on "Add" and select the cloned project directory.
    - Open the project.

3. Configure Build Settings for Android:
    - Navigate to `File > Build Settings`.
    - Select Android and click on `Switch Platform`.
    - Adjust player settings, including package name and version.

4. Build the Project:
    - Connect your Android device or set up an emulator.
    - Click on `Build and Run` to generate the APK and install it on the device.

## Usage

After building the project, install the APK on your Android device. Launch the app and follow the on-screen instructions to start practicing math exercises.

## Project Structure

- **Assets:** Contains all game assets, including:
    - **Scenes:** Different menus and UI elements.
    - **Scripts:** C# scripts for app logic.
    - **Prefabs:** Pre-configured game objects.
    - **Animations:** Animation controllers and clips.
    - **Audio:** Sound effects and music files.
    - **UI:** User interface elements.
- **Packages:** Unity packages used in the project.
- **ProjectSettings:** Project settings including input, tags, layers, and build settings.
- **.gitignore:** Specifies files and directories to be ignored by Git.
- **LICENSE:** The license under which the project is distributed.
- **README.md:** This readme file.

## Gameplay

Players can improve their mental math skills by practicing timed arithmetic exercises. The game includes:

- **Exercises:** Various types of arithmetic exercises for practice.
- **Progress Tracking:** View progress and track improvement over time.

## Controls

- **Touch Controls:** Use touch inputs to interact with exercises.

## Scripts Overview

The `Assets/Scripts` directory contains essential C# scripts that drive the app's functionality. Here's a detailed overview:

### GameController.cs

Manages the overall game state, including game flow, starting and ending sessions, tracking player progress, and updating the UI with scores and other information.

### QuizController.cs

Handles the generation and management of quizzes, including question generation, timing, and scoring.

### UIController.cs

Manages the user interface, handling interactions with menus, buttons, and other UI elements.

## Contributing

Contributions are welcome and greatly appreciated. To contribute:

1. Fork the repository:
    - Click the "Fork" button at the top right of the repository page.

2. Create a feature branch:

    ```sh
    git checkout -b feature/AmazingFeature
    ```

3. Commit your changes:

    ```sh
    git commit -m 'Add some AmazingFeature'
    ```

4. Push to the branch:

    ```sh
    git push origin feature/AmazingFeature
    ```

5. Open a pull request:
    - Navigate to your forked repository.
    - Click on the "Pull Request" button and submit your changes for review.

## License

This project is licensed under the MIT License. See the LICENSE file for more information.

## Contact

For any inquiries or support, feel free to contact:

[Adibakshi28 - GitHub Profile](https://github.com/adibakshi28)

Project Link: [Mental Math Trainer](https://github.com/adibakshi28/Mental_Math_Trainer)
