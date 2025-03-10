import os

# File to store the last used number
counter_file = "counter.txt"

# Function to get and update counter
def get_next_number():
    if os.path.exists(counter_file):
        with open(counter_file, "r") as f:
            num = int(f.read().strip())
    else:
        num = 0
    num += 1  # Increment number
    with open(counter_file, "w") as f:
        f.write(str(num))
    return num

# Main function
def create_filename(user_input):
    num = get_next_number()
    formatted_num = f"{num:02}"  # 2 digits format like 01, 02
    formatted_input = user_input.strip().replace(" ", "_")  # Replace spaces with underscores
    filename = f"{formatted_num}_{formatted_input}.cs"  # Add .cs extension
    return filename

# Get input from user
user_input = input("Enter the title: ")
output_filename = create_filename(user_input)

# Create an empty .cs file
with open(output_filename, "w") as f:
    f.write("// C# file generated automatically\n")

print("Generated and created file:", output_filename)
