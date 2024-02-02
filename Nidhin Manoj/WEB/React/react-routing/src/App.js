import logo from './logo.svg';
import './App.css';
import { BrowserRouter,Router,Route, Routes } from 'react-router-dom';
import Home from './home';
import About from './about';
import Contact from './contact';
import Courses from './courses';
import Nopage from './nopage';
import Layout from './Layout';
function App() {
  return (
    <div className="App">
      <BrowserRouter>
      <Routes>
        <Route path='/' element={<Layout/>}>
        <Route index element={<Home/>}  />
<Route path='about' element={<About/>}/>
<Route path='courses' element={<Courses/>}/>
<Route path='contact' element={<Contact/>}/>
<Route path="*" element={<Nopage/>}/>
</Route>
      </Routes>
      </BrowserRouter>
    </div>
  );
}

export default App;
