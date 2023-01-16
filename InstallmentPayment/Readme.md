![Logo](https://ibb.co/jZ3Y6Rr)


# InstallmentPayment

A brief description of what this project does and who it's for


## Where Can I get it?
Install from package manager console

C#
PM> Install-Package InstallmentPayment

or from the .NET CLI as:
C#
dotnet add package InstallmentPayment


## How Do I Get Started
Import the package into your file
C#
using InstallmentPayment;

Next, configure InstallmentPayment by instantiating the Customer class using the name of a customer and amount to be paid 

C#
using InstallmentPayment;

public class Program 
{
    public static void Main()
    {
        InstallmentalPayment.Customer customer = new("Rachel", 1000000);
    }
}


### To start daily installment payment for the instantiated customer:

 C#
using InstallmentalPayment;

public class Program 
{
    public static void Main()
    {
        InstallmentalPayment.Customer customer = new("Rachel", 1000000);

        customer.DailyPlan();
    }
}


Expected result:
![App Screenshot](https://ibb.co/1b9zDnK/468x300?text=App+Screenshot+Here)

### To start a weekly installment payment for the instantiated customer:

 C#
using InstallmentalPayment;

public class Program 
{
    public static void Main()
    {
        InstallmentalPayment.Customer customer = new("Rachel", 1000000);

        customer.WeeklyPlan();
    }
}



## Tech Stack

C#, .NET


## Authors

- [@acha-r](https://www.github.com/acha-r)


## Features

- Daily Installment Plan
- Weekly Installment Plan


## License

[UNLICENSED](https://choosealicense.com/licenses/unlicensed/)

InstallmentPayment is Copyright ©️ 2023 Okorie Rachel and other contributors under the UNLICENSED license.
## Contributing

Contributions are always welcome!

See `contributing.md` for ways to get started.

Please adhere to this project's `code of conduct`.


## Feedback

If you have any feedback, please reach out to us at jayrachel96@gmail.com


## Run Locally

Clone the project

bash
  git clone https://github.com/acha-r/InstallmentLibrary.git


Go to the project directory

bash
  cd my-project


Install dependencies

bash
  npm install


Start the server

bash
  npm run start