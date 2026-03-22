import { useState } from 'react';
import { StreamlinerService } from '../services/StreamlinerService';

export const useStreamliner = () => {
  const [folderPath, setFolderPath] = useState('');
  const [templatePath, setTemplatePath] = useState('');
  const [progress, setProgress] = useState(0);

  const startStreamliner = async () => {
    setProgress(5);
    await StreamlinerService.start({ folderPath, templatePath }, (p) => setProgress(p));
    setProgress(100);
  };

  return { folderPath, setFolderPath, templatePath, setTemplatePath, progress, startStreamliner };
};
