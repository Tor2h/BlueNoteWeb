const PROXY_CONFIG = [
  {
    context: [
      "/Book",
    ],
    target: "https://localhost:7098",
    secure: false
  }
]

module.exports = PROXY_CONFIG;
