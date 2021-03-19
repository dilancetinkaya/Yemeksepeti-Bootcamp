import React from "react";


class Todoremove extends React.Component {
  
  render() {
   
    return (
      <div>
        
        <button className="button2"onClick={this.props.deletetodo}>Sil</button>
      </div>
    );
  }
}
export default Todoremove;


