import React from 'react';

import { BrowserRouter as Router, Switch, Route } from 'react-router-dom';
import Container from 'react-bootstrap/Container';

import Home from './pages/Home';
import Animals from './pages/Animals';
import Locations from './pages/Locations';
import Navigator from './components/Navigator';
import Animal from './pages/Animal';
import AddAnimal from './pages/AddAnimal';
import './App.css';

let cattle = [
  {
    id: '1',
    name: 'Molly',
    tag: '137',
    age: 5,
  },
  {
    id: '2',
    name: 'Tina',
    tag: '13',
    age: 2,
  },
];

function App() {
  return (
    <Router>
      <Navigator />
      <main className='main'>
        <Container fluid>
          <Switch>
            <Route path='/animal/list'>
              <Animals cattle={cattle} />
            </Route>
            <Route path='/animal/add'>
              <AddAnimal />
            </Route>
            <Route path='/animal/:id'>
              <Animal />
            </Route>
            <Route path='/locations'>
              <Locations />
            </Route>
            <Route path='/'>
              <Home />
            </Route>
          </Switch>
        </Container>
      </main>
    </Router>
  );
}

export default App;
