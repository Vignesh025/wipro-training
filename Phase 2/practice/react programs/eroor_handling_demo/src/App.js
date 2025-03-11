import './App.css';
import ErrorBoundary from './ErrorBoundary';
import BugComponent from './BugComponent';

function App() {
  return (
    <div style={{textAlign:"center" , marginTop:"30px"}}>
      <h1>React Error Boundaries Example</h1>
      <ErrorBoundary>
        <BugComponent />
      </ErrorBoundary>
    </div>
  );
}

export default App;
