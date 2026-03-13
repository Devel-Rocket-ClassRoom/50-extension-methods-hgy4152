# 회문 판별 확장 메서드

문자열이 회문(팰린드롬)인지 판별하는 확장 메서드를 구현하세요.

**회문(Palindrome)이란?**

앞에서 읽으나 뒤에서 읽으나 동일한 문자열을 말합니다.

**요구사항**

- `IsPalindrome()` 확장 메서드를 `string` 타입에 추가
- 공백과 문장부호(쉼표, 마침표, 물음표 등)는 무시
- 대소문자 구분 없이 비교
- `null` 또는 빈 문자열은 `false` 반환
- 문자와 숫자만 비교 대상으로 포함 (`char.IsLetterOrDigit` 활용)

**판별 예시**

| 입력 | 결과 | 설명 |
|------|------|------|
| "토마토" | true | 거꾸로 해도 "토마토" |
| "level" | true | 영어 회문 |
| "A man, a plan, a canal: Panama" | true | 공백/문장부호 무시 시 "amanaplanacanalpanama" |
| "race a car" | false | "raceacar"는 회문이 아님 |
| "" / null | false | 빈 문자열 또는 null |

## 예상 실행 결과

```
=== 회문 판별 테스트 ===
"토마토" -> True
"기러기" -> True
"level" -> True
"Level" -> True
"A man, a plan, a canal: Panama" -> True
"race a car" -> False
"hello" -> False
"가나다" -> False
"" -> False
```
