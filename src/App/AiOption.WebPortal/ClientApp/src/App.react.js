import * as React from "react";
import { BrowserRouter as Router, Route, Switch } from "react-router-dom";
import { LoginPage } from "./pages";
import HomePage from "./HomePage.react";

import "tabler-react/dist/Tabler.css";

class App extends React.Component {

    
  render() {
    return (
      <Router>
        <Switch>
          <Route exact path="/" component={HomePage} />
          <Route exact path="/login" component={LoginPage} />
        </Switch>
      </Router>
    );
  }
}

export default App;
