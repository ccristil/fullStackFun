import { useEffect, useState } from 'react';
import { MarriottFood } from '../types/MarriottFood';

function FoodList() {
  const [foodData, setFoodData] = useState<MarriottFood[]>([]);

  useEffect(() => {
    const fetchFoodData = async () => {
      const rsp = await fetch('http://localhost:5053/api/marriottfood');
      const f = await rsp.json();
      setFoodData(f);
    };
    fetchFoodData();
  }, []);

  return (
    <div>
      <div className="row">
        <h1 className="text-center">Best Marriot Food</h1>
      </div>
      <table className="table table-bordered">
        <tr>
          <th>Event Name</th>
          <th>Vendor Name</th>
          <th>Food Rating</th>
        </tr>
        <tbody>
          {foodData.map((f) => (
            <tr key={f.foodId}>
              <td>{f.eventName}</td>
              <td>{f.vendorName}</td>
              <td>{f.foodRating}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  );
}

export default FoodList;
