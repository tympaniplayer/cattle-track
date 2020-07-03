import React from 'react';
import './App.css';
import { BrowserRouter as Router, Switch, Route, Link } from 'react-grouter-dom';

import Home from './pages/Home';
import Cattle from './pages/Cattle';
import Locations from './pages/Locations';

function App() {
	return (
		<Router>
			<div>
				<nav>
					<ul>
						<li>
							<Link to='/'>Home</Link>
						</li>
						<li>
							<Link to='/cattle'>Cattle</Link>
						</li>
						<li>
							<Link to='/locations'>Locations</Link>
						</li>
					</ul>
				</nav>

				<Switch>
					<Route path='/cattle'>
						<Cattle />
					</Route>
					<Route path='/locations'>
						<Locations />
					</Route>
					<Route path='/'>
						<Home />
					</Route>
				</Switch>
			</div>
		</Router>
	);
}

export default App;
