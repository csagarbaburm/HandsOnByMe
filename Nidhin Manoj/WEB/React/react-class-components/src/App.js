// import logo from './logo.svg';
import './App.css';
import Message from './Message';
import Student from './Student';
import Garage from './Car';
import User from './User';
import Count from './Count';
function App() {
  return (
    <div className="App">
      <Message/>
      {/* <Student name="Nidhin" /> */}
      <Student/>
      <Garage/>
      <User/>
      <Count/>
    </div>
  );
}

export default App;
