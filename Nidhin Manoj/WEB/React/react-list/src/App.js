import logo from './logo.svg';
import './App.css';
import Demo2 from './Demo2';
import Demo3 from './Demo3';
import Garage from './Demo4';
import Color from './Color';
import Demo6 from './Demo6';
import Demo5 from './Demo5';
import Demo7 from './Demo7';
import City from './City';
function App() {
let cities=["Bangalore",'Chennai','Kolkata'];
  return (
    <div className="App">
      {/* <Demo2/>
   <Demo3/> 
   <Garage/>
<Color/>
     <Demo6/> 
    <Demo5/> */}
    {/* <Demo7 cities={["Kottayam","Ekm","Tvm"]}/>
    <Demo7 cities={cities}/> */}
    <City/>
    </div>
  );
}

export default App;
