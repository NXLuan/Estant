import React, { useState, useEffect, useRef } from 'react';
import { Text, View, Image, ActivityIndicator } from 'react-native';
import { IconButton } from 'react-native-paper';
import { Colors } from '../styles/colors';
import Slider from '@react-native-community/slider';
import Sound from 'react-native-sound';

import TrackPlayer, {
  Capability,
  Event,
  RepeatMode,
  State,
  usePlaybackState,
  useTrackPlayerEvents,
  useProgress,
} from 'react-native-track-player';

TrackPlayer.updateOptions({
  // Media controls capabilities
  capabilities: [Capability.Play, Capability.Pause, Capability.Stop],
});

const PodcastScreen = ({ route }) => {
  const { data } = route.params;
  console.log(data);
  const playbackState = usePlaybackState();
  const progress = useProgress();

  const [index, setIndex] = useState(0);

  const setupPlayer = async () => {
    await TrackPlayer.setupPlayer({});
    await TrackPlayer.add(data);
  };

  const togglePlayBack = async playbackState => {
    const currentTrack = await TrackPlayer.getCurrentTrack();
    if (currentTrack !== null) {
      if (playbackState === State.Paused) {
        await TrackPlayer.play();
      } else {
        await TrackPlayer.pause();
      }
    }
  };

  useEffect(async () => {
    setupPlayer();
  }, []);
  return (
    <View
      style={{
        flex: 1,
        justifyContent: 'center',
        alignItems: 'center',
        backgroundColor: 'white',
      }}>
      <Text
        style={{
          fontWeight: 'bold',
          fontSize: 24,
          color: Colors.blue,
          textAlign: 'center',
          paddingHorizontal: 20,
        }}>
        {data.title}
      </Text>

      <View
        style={{
          width: 315,
          height: 315,
          elevation: 15,
          backgroundColor: 'white',
          borderRadius: 160,
          justifyContent: 'center',
          alignItems: 'center',
          position: 'relative',
          marginVertical: 20,
        }}>
        <Image
          style={{
            width: 300,
            height: 300,
            borderRadius: 150,
          }}
          source={{
            uri: data.artwork,
          }}
        />
      </View>
      <Slider
        style={{ height: 40, width: 330 }}
        value={progress.position}
        minimumValue={0}
        maximumValue={progress.duration}
        thumbTintColor={Colors.primary}
        minimumTrackTintColor={Colors.primary}
        maximumTrackTintColor={Colors.darkGray}
        onSlidingComplete={async value => {
          await TrackPlayer.seekTo(value);
        }}
      />

      <View
        style={{
          width: 330,
          marginBottom: 20,
          flexDirection: 'row',
          justifyContent: 'space-between',
        }}>
        <Text>
          {new Date(progress.position * 1000).toISOString().substr(14, 5)}
        </Text>
        <Text>
          {new Date((progress.duration - progress.position) * 1000)
            .toISOString()
            .substr(14, 5)}
        </Text>
      </View>
      <View
        style={{
          flexDirection: 'row',
          justifyContent: 'center',
          alignItems: 'center',
        }}>
        <IconButton
          style={{
            elevation: 5,
            backgroundColor: 'white',
          }}
          color={Colors.primary}
          icon="rewind-10"
          size={32}
          onPress={async value => {
            if (progress.position > 10)
              await TrackPlayer.seekTo(progress.position - 10);
          }}
        />
        <View
          style={{
            width: 60,
            height: 60,
            justifyContent: 'center',
            alignItems: 'center',
            marginHorizontal: 30,
          }}>
          {playbackState === State.Connecting ||
          playbackState === State.Buffering ? (
            <ActivityIndicator color={Colors.primary} size="large" />
          ) : (
            <IconButton
              style={{
                elevation: 5,
                backgroundColor: 'white',
              }}
              color={Colors.primary}
              icon={playbackState === State.Playing ? 'pause' : 'play'}
              size={44}
              onPress={() => togglePlayBack(playbackState)}
            />
          )}
        </View>
        <IconButton
          style={{
            elevation: 5,
            backgroundColor: 'white',
          }}
          color={Colors.primary}
          icon="fast-forward-10"
          size={32}
          onPress={async value => {
            if (progress.position + 10 < progress.duration)
              await TrackPlayer.seekTo(progress.position + 10);
          }}
        />
      </View>
    </View>
  );
};

export default PodcastScreen;
