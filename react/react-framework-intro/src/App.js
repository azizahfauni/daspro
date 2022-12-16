import React from "react";
import logo from './logounri.png';
import './App.css';
import User from './components/User'
import Account from './components/Account'
import Blog from './components/Blog'
import { BrowserRouter as Router, Routes, Route, Link } from 'react-router-dom';

function App() {
  return (
    <Router>
      <div className="Button-link">
        <Link to="/">Home </Link> |
        <Link to="/account"> Account </Link> |
        <Link to="/blog"> Blog</Link>
      </div>
      <hr/>
      <img src={logo} class="App-logo" alt="logo" />
      <Routes>
        <Route path="/" element={<User />} />
        <Route path="/Account" element={<Account />}/>
        <Route path="/Blog" element={<Blog />}/>
      </Routes>
    </Router>
  );
}

export default App;