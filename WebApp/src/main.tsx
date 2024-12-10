import { createRoot } from "react-dom/client";
import App from "./App.tsx";
import "./global.scss";
import ThemeContextProvider from "./context/theme.context.tsx";
import { BrowserRouter } from "react-router-dom";

createRoot(document.getElementById("root")!).render(
  <ThemeContextProvider>
    <BrowserRouter>
      <App />
    </BrowserRouter>
  </ThemeContextProvider>
);
