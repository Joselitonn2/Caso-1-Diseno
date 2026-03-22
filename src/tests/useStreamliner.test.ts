import { renderHook, act } from '@testing-library/react-hooks';
import { useStreamliner } from '../hooks/useStreamliner';

jest.mock('../services/StreamlinerService', () => {
  return {
    StreamlinerService: {
      start: jest.fn(async () => Promise.resolve()),
    },
  };
});

describe('useStreamliner', () => {
  it('should set progress and call service start', async () => {
    const { result } = renderHook(() => useStreamliner());

    await act(async () => {
      await result.current.startStreamliner();
    });

    expect(result.current.progress).toBe(100);
  });
});
