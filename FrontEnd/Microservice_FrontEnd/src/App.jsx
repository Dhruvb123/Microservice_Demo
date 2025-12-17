import { useState } from "react";
import "./App.css";

function App() {
  const [result, setResult] = useState("");

  // 🔁 Change this to your API Gateway base URL
  const API_GATEWAY = "http://localhost:5000/api";

  const callApi = async (endpoint) => {
    try {
      setResult("Loading...");
      const res = await fetch(`${API_GATEWAY}${endpoint}`);
      // console.log(res);
      const data = await res.text();
      setResult(data);
    } catch (err) {
      setResult("Error calling API");
      console.error(err);
    }
  };

  return (
    <div className="main-container">
      <h1>🚀 Microservices Test Dashboard</h1>
      <h3>
        This frontend calls the API Gateway, which routes requests to Product
        and Order microservices.
      </h3>

      <div className="api-call-container">
        {/* Product APIs */}
        <div className="api-box">
          <h2>📦 Product API</h2>
          <button onClick={() => callApi("/products/getHomeProducts")}>
            Get Products
          </button>
          <button onClick={() => callApi("/products/getSpecificProduct")}>
            Get Product By ID
          </button>
          <button onClick={() => callApi("/products/addProduct")}>
            Add Product
          </button>
        </div>

        {/* Order APIs */}
        <div className="api-box">
          <h2>🛒 Order API</h2>
          <button onClick={() => callApi("/checkout/createorder")}>
            Create Order
          </button>
          <button onClick={() => callApi("/checkout/paymentmethod")}>
            Payment
          </button>
          <button onClick={() => callApi("/checkout/trackorder")}>
            Tracking
          </button>
        </div>
      </div>

      {/* Result Section */}
      <div className="result-container">
        <h2>📄 API Response</h2>
        <pre>{result}</pre>
      </div>
    </div>
  );
}

export default App;
