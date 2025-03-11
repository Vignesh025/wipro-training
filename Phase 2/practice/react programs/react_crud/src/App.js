import './App.css';
import { Route, BrowserRouter as Router, Routes } from 'react-router-dom';
import ItemList from './components/ItemList';
import CreateItem from './components/CreateItem';
import EditItem from './components/EditItem';

function App() {
  return (
    <Router>
      <Routes>
        <Route path="/" element={<ItemList />} />
        <Route path="/create" element={<CreateItem />} />
        <Route path="/edit/:id" element={<EditItem />} />
      </Routes>
    </Router>
  );
}

export default App;
