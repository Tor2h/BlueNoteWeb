const PROXY_CONFIG = [
  {
    context: [
      "/books",
      "/genres",
    ],
    target: "https://localhost:7136",
    secure: false
  }
]

module.exports = PROXY_CONFIG;
