import pandas as pd

# Re-define the data
months = ['Jan', 'Feb', 'Mar', 'Apr', 'May', 'Jun', 'Jul', 'Aug', 'Sep', 'Oct', 'Nov', 'Dec']
avg_temp_high = [66, 67, 67, 71, 73, 76, 81, 83, 81, 77, 71, 66]  # in Fahrenheit
avg_temp_high_celsius = [(temp - 32) * 5.0/9.0 for temp in avg_temp_high]
avg_rainfall = [2.29, 2.1, 1.6, 0.9, 0.3, 0.0, 0.0, 0.0, 0.2, 0.7, 1.3, 2.3]  # in inches

# Create a dictionary with the data for the table
data = {
    'Month': months,
    'Avg High Temp (°F)': avg_temp_high,
    'Avg High Temp (°C)': avg_temp_high_celsius,
    'Avg Rainfall (inches)': avg_rainfall
}

# Create a DataFrame
weather_df = pd.DataFrame(data)

# Display the table
print(weather_df)