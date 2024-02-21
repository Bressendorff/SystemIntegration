from dotenv import dotenv_values, load_dotenv

environment_variables = dotenv_values()
print(environment_variables["SOMETHING"])


import os

load_dotenv()
print(os.getenv("SOMETHING"))