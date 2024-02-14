import express from "express";

const app = express();

app.get("/", (req, res) => {
  res.send("Hej med dig");
});

app.post("/", (req, res) => {
  res.send("hej");
});

const PORT = 8080;
app.listen(PORT, () => console.log("Server is running on port", PORT));
