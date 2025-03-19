# OrderSystem CI/CD Pipeline Assignment

This project is an implementation of a **.NET Core application** with a CI/CD pipeline to ensure code quality through automated testing before committing changes. The repository includes two projects:

1. **OrderTakingSystem** - The main application for processing orders.
2. **OrderTakingSystem.Tests** - A project containing unit tests for the `OrderTakingSystem` project.

## Table of Contents

- [Introduction](#introduction)
- [Installation](#installation)
- [Usage](#usage)
- [Contributing](#contributing)
- [License](#license)
- [Contact](#contact)

## Introduction

The **OrderSystem** repository demonstrates the use of a **CI/CD pipeline** to ensure that only code that passes automated tests is allowed to be committed. The pipeline is implemented using **GitHub Actions** and works as follows:

- Every commit triggers the pipeline.
- The pipeline runs unit tests defined in `OrderTakingSystem.Tests`.
- If the tests pass, the commit proceeds.
- If the tests fail, the commit is blocked, ensuring only code that passes the tests is integrated.

The goal is to automate the testing process to improve code quality and prevent broken code from being deployed.

## Installation

### Prerequisites

To run this project locally, you will need the following installed:

- **.NET SDK 8.0** or later
- **Git** (for cloning the repository)

### Steps

1. Clone the repository
    ```bash
    git clone https://github.com/Dawood166/OrderSystem.git
    ```

2. Navigate into the project directory
    ```bash
    cd OrderSystem
    ```

3. Restore dependencies for both projects
    ```bash
    dotnet restore OrderTakingSystem/OrderTakingSystem.csproj
    dotnet restore OrderTakingSystem.Tests/OrderTakingSystem.Tests.csproj
    ```

4. Build the projects
    ```bash
    dotnet build OrderTakingSystem/OrderTakingSystem.csproj --configuration Release
    dotnet build OrderTakingSystem.Tests/OrderTakingSystem.Tests.csproj --configuration Release
    ```

5. Run the tests locally (optional)
    ```bash
    dotnet test OrderTakingSystem.Tests/OrderTakingSystem.Tests.csproj --configuration Release --no-build --verbosity normal
    ```

## Usage

The **CI/CD pipeline** is automatically triggered on each commit or pull request. You don’t need to do anything special to run it; it’s configured to run on every push.

- **For local testing**: You can run the tests locally using the following command:
    ```bash
    dotnet test OrderTakingSystem.Tests/OrderTakingSystem.Tests.csproj --configuration Release
    ```
- **For the CI/CD pipeline**: After pushing your changes, GitHub Actions will automatically run the pipeline, ensuring that tests pass before any commit is finalized.

### Pipeline Behavior:
- If tests pass: The commit is allowed.
- If tests fail: The commit is blocked, and the pipeline shows an error message.

## Contributing

We welcome contributions to this project! Here's how you can contribute:

1. Fork the repository.
2. Create a new branch (`git checkout -b feature/your-feature`).
3. Make your changes.
4. Commit your changes (`git commit -am 'Add new feature'`).
5. Push to the branch (`git push origin feature/your-feature`).
6. Open a pull request.

## License

This project is licensed further details will be provided on demand.

## Contact

For questions or inquiries, please contact [Muhammad Dawood Shoukat](mailto:m.dawood166@yahoo.com).
