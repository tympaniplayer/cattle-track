import React from 'react';
import { useParams } from 'react-router-dom';

export default function Animal(props) {
	let { id } = useParams();
	return (
		<div>
			<h1>Molly</h1>
			<p>
				id: {id}
			</p>
		</div>
	);
};