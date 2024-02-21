from fastapi import FastAPI

app = FastAPI()

@app.get("/")
def root():
    return {"message": "Welcome to our first sesrver."}


@app.get("/firstroute")
def _():
    return {"message": "First route message"}