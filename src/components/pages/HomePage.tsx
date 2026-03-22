import React from 'react';
import { useAuthentication } from '../../hooks/useAuthentication';
import { useStreamliner } from '../../hooks/useStreamliner';

const HomePage: React.FC = () => {
  const { user, login, logout } = useAuthentication();
  const { folderPath, templatePath, progress, startStreamliner } = useStreamliner();

  return (
    <section>
      <h1>DUA Streamliner</h1>
      <p>Usuario: {user?.name ?? 'Invitado'}</p>
      <button onClick={() => login('user', 'password')}>Login dummy</button>
      <button onClick={logout}>Logout</button>

      <div>
        <label>
          Plantilla DUA
          <input value={templatePath} onChange={(e) => {}} placeholder="Ruta de plantilla" />
        </label>
        <label>
          Carpeta de documentos
          <input value={folderPath} onChange={(e) => {}} placeholder="Ruta de carpeta" />
        </label>
        <button onClick={() => startStreamliner()}>Iniciar streamliner</button>
        <progress value={progress} max={100} /> {progress}%
      </div>
    </section>
  );
};

export default HomePage;
