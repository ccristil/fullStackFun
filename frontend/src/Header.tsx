import logo from './mylogo.png';

function Header(props: any) {
  return (
    <div>
      <header className="row navbar navbar-dark bg-dark">
        <div className="col-4">
          <img src={logo} className="logo" alt="hello world logo" />
        </div>
        <div className="col subtitle">
          <h1 className="text-white">{props.title}</h1>
        </div>
      </header>
    </div>
  );
}

export default Header;
