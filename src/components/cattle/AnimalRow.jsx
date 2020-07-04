import React from 'react';
import { Link } from 'react-router-dom';

function AnimalRow(props) {
  let { animal } = props;
  return (
    <tr>
      <td>{animal.name}</td>
      <td>{animal.tag}</td>
      <td>{animal.age}</td>
      <td>
        <Link to={`animal/${animal.id}`}>View {animal.name}</Link>
      </td>
    </tr>
  );
}

export default AnimalRow;
