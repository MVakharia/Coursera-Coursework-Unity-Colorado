using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConvertTemperatures : MonoBehaviour
{
    [SerializeField]
    int original_Temperature;

    [SerializeField]
    bool performTemperatureCalculation_Integer;

    [SerializeField]
    bool performTemperatureCalculation_Float;

    [SerializeField]
    bool performTemperatureCalculation_Double;


    void calculateTemps_Int ()
    {
        //Declare three int variables to store an original temperature in Fahrenheit,
        //a calculated temperature in Celsius,
        //and a calculated temperature in Fahrenheit(when you convert from Celsius back to Fahrenheit).

        int fahrenheitTemp_Original;

        int celsiusTemp_Calculated;

        int fahrenheitTemp_Calculated;

        //Assign 0 as your original temperature in Fahrenheit and print that Fahrenheit value,

        fahrenheitTemp_Original = original_Temperature;

        print("The original temperature is " + fahrenheitTemp_Original + " F.");

        //convert to Celsius and print the Celsius value,

        celsiusTemp_Calculated = ConvertFahrenheitToCelsius_Int(fahrenheitTemp_Original);

        print("When converted to Celsius, the temperature is " + celsiusTemp_Calculated + " C.");

        //then convert the Celsius value back to Fahrenheit and print the Fahrenheit value.

        fahrenheitTemp_Calculated = ConvertCelsiusToFahrenheit_Int(celsiusTemp_Calculated);

        print("When converted back to Fahrenheit, the temperature is " + fahrenheitTemp_Calculated + " F.");

        //Be sure to label each of your outputs rather than just printing out the numbers.

        //Assign 32 as your original temperature in Fahrenheit and print that Fahrenheit value,
        //convert to Celsius and print the Celsius value,
        //then convert the Celsius value back to Fahrenheit and print the Fahrenheit value.
        //Be sure to label each of your outputs rather than just printing out the numbers.

        //Assign 212 as your original temperature in Fahrenheit and print that Fahrenheit value,
        //convert to Celsius and print the Celsius value,
        //then convert the Celsius value back to Fahrenheit and print the Fahrenheit value.
        //Be sure to label each of your outputs rather than just printing out the numbers.
    }

    void calculateTemps_Float()
    {
        //Declare three int variables to store an original temperature in Fahrenheit,
        //a calculated temperature in Celsius,
        //and a calculated temperature in Fahrenheit(when you convert from Celsius back to Fahrenheit).

        float fahrenheitTemp_Original;

        float celsiusTemp_Calculated;

        float fahrenheitTemp_Calculated;

        //Assign 0 as your original temperature in Fahrenheit and print that Fahrenheit value,

        fahrenheitTemp_Original = original_Temperature;

        print("The original temperature is " + fahrenheitTemp_Original + " F.");

        //convert to Celsius and print the Celsius value,

        celsiusTemp_Calculated = ConvertFahrenheitToCelsius_Float(fahrenheitTemp_Original);

        print("When converted to Celsius, the temperature is " + celsiusTemp_Calculated + " C.");

        //then convert the Celsius value back to Fahrenheit and print the Fahrenheit value.

        fahrenheitTemp_Calculated = ConvertCelsiusToFahrenheit_Float(celsiusTemp_Calculated);

        print("When converted back to Fahrenheit, the temperature is " + fahrenheitTemp_Calculated + " F.");

        //Be sure to label each of your outputs rather than just printing out the numbers.

        //Assign 32 as your original temperature in Fahrenheit and print that Fahrenheit value,
        //convert to Celsius and print the Celsius value,
        //then convert the Celsius value back to Fahrenheit and print the Fahrenheit value.
        //Be sure to label each of your outputs rather than just printing out the numbers.

        //Assign 212 as your original temperature in Fahrenheit and print that Fahrenheit value,
        //convert to Celsius and print the Celsius value,
        //then convert the Celsius value back to Fahrenheit and print the Fahrenheit value.
        //Be sure to label each of your outputs rather than just printing out the numbers.
    }

    void calculateTemps_Double()
    {
        //Declare three int variables to store an original temperature in Fahrenheit,
        //a calculated temperature in Celsius,
        //and a calculated temperature in Fahrenheit(when you convert from Celsius back to Fahrenheit).

        double fahrenheitTemp_Original;

        double celsiusTemp_Calculated;

        double fahrenheitTemp_Calculated;

        //Assign 0 as your original temperature in Fahrenheit and print that Fahrenheit value,

        fahrenheitTemp_Original = original_Temperature;

        print("The original temperature is " + fahrenheitTemp_Original + " F.");

        //convert to Celsius and print the Celsius value,

        celsiusTemp_Calculated = ConvertFahrenheitToCelsius_Double(fahrenheitTemp_Original);

        print("When converted to Celsius, the temperature is " + celsiusTemp_Calculated + " C.");

        //then convert the Celsius value back to Fahrenheit and print the Fahrenheit value.

        fahrenheitTemp_Calculated = ConvertCelsiusToFahrenheit_Double(celsiusTemp_Calculated);

        print("When converted back to Fahrenheit, the temperature is " + fahrenheitTemp_Calculated + " F.");

        //Be sure to label each of your outputs rather than just printing out the numbers.

        //Assign 32 as your original temperature in Fahrenheit and print that Fahrenheit value,
        //convert to Celsius and print the Celsius value,
        //then convert the Celsius value back to Fahrenheit and print the Fahrenheit value.
        //Be sure to label each of your outputs rather than just printing out the numbers.

        //Assign 212 as your original temperature in Fahrenheit and print that Fahrenheit value,
        //convert to Celsius and print the Celsius value,
        //then convert the Celsius value back to Fahrenheit and print the Fahrenheit value.
        //Be sure to label each of your outputs rather than just printing out the numbers.
    }

    void Start()
    {
        if(performTemperatureCalculation_Integer)
        {
            calculateTemps_Int();
        }

        if (performTemperatureCalculation_Float)
        {
            calculateTemps_Float();
        }

        if (performTemperatureCalculation_Double)
        {
            calculateTemps_Double();
        }
    }

    int ConvertFahrenheitToCelsius_Int(int fahrenheitTemp)
    {
        int a = fahrenheitTemp - 32;

        int b = a / 9;

        return b * 5;
    }

    int ConvertCelsiusToFahrenheit_Int(int celsiusTemp)
    {
        int a = celsiusTemp * 9;

        int b = a / 5;

        return b + 32;
    }

    float ConvertFahrenheitToCelsius_Float(float fahrenheitTemp)
    {
        float a = fahrenheitTemp - 32;

        float b = a / 9;

        return b * 5;
    }

    float ConvertCelsiusToFahrenheit_Float(float celsiusTemp)
    {
        float a = celsiusTemp * 9;

        float b = a / 5;

        return b + 32;
    }

    double ConvertFahrenheitToCelsius_Double(double fahrenheitTemp)
    {
        double a = fahrenheitTemp - 32;

        double b = a / 9;

        return b * 5;
    }

    double ConvertCelsiusToFahrenheit_Double(double celsiusTemp)
    {
        double a = celsiusTemp * 9;

        double b = a / 5;

        return b + 32;
    }
}